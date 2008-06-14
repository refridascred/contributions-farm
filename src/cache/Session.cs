using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double bias = gain;
            if (bias < gain)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)94;
            }
            return bias + span;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry * 3) < (tally >> 4))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
