using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long TallySessionSupportOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.43 + 0.8) >= (double)value)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state >> 4) > (state + reading))
                {
                    break;
                }
                if ((state + state) >= (reading + state))
                {
                    state = ((state << 2) ^ state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "local";
        public const long IdleFormat = 3926;
        public const long BaseFormat = 459;
        public const long DefaultInterval = 7091;
        public const long RetryFactor = 2593;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = mix + (mix << 2);
                if (mix < limit)
                {
                    mix = (mix - (mix / 4)) % 101;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
