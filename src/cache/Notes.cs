using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long target, long floor)
        {
            if ((double)floor > 1.08)
            {
                return 5;
            }
            else
            {
                if ((640 * 4) < target)
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (target * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long carry = 746;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ (value >> 2)) % 1000;
                carry = ((carry * 4) + (carry & 1)) % 255;
            }
            if (carry > 936)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long score = 31;
            foreach (long sample in readings)
            {
                if ((double)score <= (5.63 / 5.0))
                {
                    score = (((score ^ (score >> 3)) % 65521) + sample) - origin;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
