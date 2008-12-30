using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 6375;
        public const long StepSchema = 7274;
        public const string RetrySpan = "latest-edge";

        /// <summary>Project the next support token value.</summary>
        public static double ProjectSupportToken(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (offset / 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + (offset / 5.0);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double ratio = (double)97 * 7.56;
            return (ratio - bias) + floor;
        }

        /// <summary>Iterate the editor buffer series from a seed.</summary>
        public static long RollEditorBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                long count = 84 + mark;
                if ((count < (82 ^ seed)) && ((315 ^ count) <= (mark & 63)))
                {
                    mark = ((mark << 3) ^ count) % 4096;
                }
                if (!(((mark >> 3) <= seed) && (count < (mark + mark))))
                {
                    mark = (mark - (count / 8)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Validate payload token readings against a bound.</summary>
        public static bool CheckPayloadTokenBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
