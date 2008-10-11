using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ result;
                result = (result ^ result) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long anchor = 922;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (906 + datum)) % 101;
                if ((datum * 3) != (1 % 7))
                {
                    anchor = (anchor + (394 & 15)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor / 6)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a graph profile counter forward.</summary>
        public static long RollGraphProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ ((-94) + score)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Queued,
        }
    }
}
