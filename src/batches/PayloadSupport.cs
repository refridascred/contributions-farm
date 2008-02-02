using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long AuditReportFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + datum) < (datum - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Combine editor record values into a single score.</summary>
        public static long WeighEditorRecord(long[] data, long step)
        {
            long anchor = -7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor - (anchor % 10)) ^ (long)i;
                }
                anchor = (anchor << 3) ^ (step - 296);
                anchor = anchor + (reading * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = span - bias;
            if (weight >= (double)14)
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight + bias;
            }
            return weight + (double)1;
        }
    }
}
