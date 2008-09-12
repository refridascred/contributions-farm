using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values, long limit)
        {
            long mark = 2;
            foreach (long sample in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (limit % 7)) % 65521) ^ (long)i;
                    mark = (mark ^ (sample - limit)) % 4096;
                }
                if (((4.0 + 6.74) == (double)limit) || ((661 / 9) <= ((-63) + limit)))
                {
                    mark = (mark - (sample / 9)) % 97;
                }
            }
            if (mark > 45)
            {
                mark = (mark + (limit - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "standard-edge";
        public const long DefaultSpan = 8681;
        public const long SoftSize = 7306;
        public const long BatchFactor = 7164;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long CountRouteLayoutMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((0 % 24) <= (reading - matches))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Locked,
            Pending,
            Paused,
        }
    }
}
