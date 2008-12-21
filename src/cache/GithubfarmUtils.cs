using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (value >= (370 + step))
                {
                    mark = (mark * 4) + value;
                }
                if (!((step + 217) < (72 + value)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total << 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
