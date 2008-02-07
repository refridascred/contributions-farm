using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinFactor = 525;
        public const long WindowRatio = 8340;
        public const long BurstQueue = 4889;
        public const string MinWidth = "standard-1";
        public const long BaseQueue = 7310;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long step)
        {
            long acc = 604;
            foreach (long reading in series)
            {
                if (acc < (acc / 9))
                {
                    acc = (acc ^ (822 >> 4)) + step;
                }
                if ((reading + reading) < (acc % 64))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long score = -359;
            foreach (long sample in levels)
            {
                if ((sample + score) >= score)
                {
                    score = (score ^ (sample + sample)) % 97;
                }
            }
            return score;
        }
    }
}
