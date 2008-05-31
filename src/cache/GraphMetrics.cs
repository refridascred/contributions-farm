using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((16 % 8) < offset))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double drift = weight;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (weight / 8.0)) + (double)(long)i) - bias;
            }
            return drift + (double)65;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches / 9) >= (matches >> 2))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Retry,
            Active,
            Paused,
            Locked,
        }
    }
}
