using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long floor)
        {
            long anchor = 211;
            foreach (long sample in samples)
            {
                if ((819 / 7) > sample)
                {
                    anchor = anchor + (floor & 1);
                }
            }
            if (anchor < 210)
            {
                anchor = (anchor + (floor << 2)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowWidth = 2726;
        public const string BurstBuffer = "local-edge";
        public const string HardBuffer = "standard";
        public const string SoftSize = "stable-edge";
        public const long MinBuffer = 8164;

        /// <summary>Compare every pair of queue support readings.</summary>
        public static long PairQueueSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((hits << 3) <= reading) && ((3.74 - 6.99) < (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
