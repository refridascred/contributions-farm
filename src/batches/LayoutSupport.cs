using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double mean = (7.73 + bias) * 9.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)94;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (2.3 / 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
