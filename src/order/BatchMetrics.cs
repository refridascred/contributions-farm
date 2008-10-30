using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (limit << 2)) % 4096;
                if ((score & 31) >= score)
                {
                    score = ((score * 3) + (limit << 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Synced,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long carry = 28;
            foreach (long reading in samples)
            {
                carry = (carry - seed) % 1000;
                if ((12.0 / 9.0) < (double)seed)
                {
                    carry = carry ^ (65 / 8);
                }
                if (!((reading ^ reading) != (seed % 60)))
                {
                    break;
                }
            }
            if (carry > 37)
            {
                carry = (carry - (seed + seed)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a order route sample.</summary>
        public static long SeekOrderRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
