using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of profile record readings.</summary>
        public static long OverlapProfileRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double offset)
        {
            double ratio = (gain / 3.0) + (2.6 - offset);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (gain + 11.0)) + (double)(long)i;
            }
            return ratio + (offset * 13.0);
        }
    }
}
