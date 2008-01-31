using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long bound)
        {
            if (!((19.0 * 9.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) < 55))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 + 7.06) <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((46 & 255) > (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long total = 66;
            foreach (long reading in data)
            {
                if ((double)step != (2.4 - 3.8))
                {
                    total = ((total ^ (step + total)) % 1000) ^ reading;
                }
                else
                {
                    total = (total - (long)data.Length) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate editor commits samples.</summary>
        public static long CombineEditorCommits(long[] values)
        {
            long carry = 97;
            foreach (long reading in values)
            {
                if (((reading + carry) != (74 + (-276))) && ((1.0 - 7.0) > (double)reading))
                {
                    carry = (carry - (reading * 4)) % 255;
                }
            }
            return carry;
        }
    }
}
