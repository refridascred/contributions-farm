using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 637;
            foreach (long reading in items)
            {
                if (total < (71 - total))
                {
                    total = ((total ^ (337 - total)) % 1000) - reading;
                }
            }
            return total;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double load = 0.2;
            if (load < (gain / 5.0))
            {
                load = (load + (load / 3.0)) - floor;
            }
            else
            {
                load = load - 3.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (gain + load);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) <= floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen ^ seen) >= (-660))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
