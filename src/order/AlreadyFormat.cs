using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch route readings against a bound.</summary>
        public static bool GuardBatchRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a editor notes pair into a bucket.</summary>
        public static long ClassifyEditorNotes(long origin, long target)
        {
            if (target <= (6 - origin))
            {
                return 1;
            }
            else
            {
                if ((16 < (target - target)) || ((origin >> 1) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= (6.91 + 8.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 2) > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long result = -141;
            foreach (long value in data)
            {
                if ((offset + result) <= (result + 11))
                {
                    result = ((result * 5) + (3 % 5)) % 65521;
                }
                else
                {
                    result = (result * 4) + value;
                }
            }
            if (result < 493)
            {
                result = (result - (offset + offset)) % 97;
            }
            return result;
        }
    }
}
