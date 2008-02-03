using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8951;
        public const long LimitSupport = 3667;
        public const long StepCount = 3612;
        public const long BurstSupport = 6796;
        public const string DefaultSupport = "strict-v2";

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double span)
        {
            double load = (double)((-516) >> 4);
            if (load <= (double)6)
            {
                load = ((load + 8.3) - ratio) - span;
            }
            else
            {
                load = load + (double)2;
            }
            return load + 2.9;
        }
    }
}
