using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "strict-edge";
        public const long IdleSpan = 4863;
        public const long BurstInterval = 7202;
        public const long IdleAlready = 9543;
        public const long MaxAlready = 7623;

        /// <summary>Look up the position of a editor notes sample.</summary>
        public static long SeekEditorNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset - target;
            if (((bound << 2) >= 9) && ((target ^ offset) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) == (offset & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            long prev = bound ^ floor;
            if ((floor + bound) >= (floor % 60))
            {
                return 2;
            }
            else
            {
                if ((prev * 2) >= prev)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long limit)
        {
            long carry = 78;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (carry - item)) % 101;
            }
            if (carry < 34)
            {
                carry = (carry + (carry - limit)) % 65521;
            }
            return carry;
        }
    }
}
