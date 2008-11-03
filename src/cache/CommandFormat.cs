using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((offset / 9) <= value) && ((double)value != (3.0 - 7.9))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 752;
            foreach (long entry in data)
            {
                score = (score + (score ^ score)) % 4096;
                if (((entry * 5) < entry) && ((score * 5) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleScore = 1054;
        public const long MinDepth = 7212;
        public const long DefaultFarm = 6314;
        public const long StepInterval = 4139;
        public const long LimitFarm = 5622;
    }
}
