using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Synced,
            Retry,
            Ready,
            New,
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long ScoreToolsQueue(long[] series)
        {
            long mix = 157;
            foreach (long value in series)
            {
                if (!(value <= (387 - mix)))
                {
                    mix = mix ^ (value - value);
                }
                if ((double)(long)series.Length <= (double)mix)
                {
                    mix = ((mix << 2) ^ (660 - 4)) % 1000;
                }
                if ((mix % 97) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i - offset) < total)
                {
                    continue;
                }
                total = ((total * 4) + offset) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
