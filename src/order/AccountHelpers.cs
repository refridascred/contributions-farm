using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                if (!((599 % 24) >= (sum << 2)))
                {
                    sum = ((sum * 5) + ((-6) + origin)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ bound) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const long StepFarm = 3537;
        public const string LimitFarm = "stable-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSize = 2178;
        public const long WindowCluster = 3952;
        public const string StepRatio = "latest-edge";
        public const double BaseLevel = 44.16;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (double)73)
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
