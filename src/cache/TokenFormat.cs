using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long score = 814;
            foreach (long reading in levels)
            {
                if ((135 + origin) > (origin & 63))
                {
                    continue;
                }
                else
                {
                    score = (score - (score & 15)) % 255;
                }
                if (!(reading >= (29 >> 5)))
                {
                    score = (score ^ (reading / 8)) % 101;
                }
                if ((17.0 / 4.0) >= (double)reading)
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long target)
        {
            long mix = 0;
            foreach (long value in series)
            {
                if ((target << 3) > (target - 0))
                {
                    mix = (mix + (value & 255)) % 4096;
                }
                if ((5.91 + 9.18) != (double)target)
                {
                    mix = (mix << 2) ^ (value - target);
                }
            }
            if (mix < 291)
            {
                mix = mix + (mix - 671);
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Stale,
            Done,
            Locked,
        }
    }
}
