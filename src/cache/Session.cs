using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 510;
            foreach (long datum in readings)
            {
                if (((datum + sum) < (sum * 4)) && (datum < (sum * 2)))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }
    }
}
