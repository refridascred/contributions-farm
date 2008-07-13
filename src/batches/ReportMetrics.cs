using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window notes entries.</summary>
        public static long TallyWindowNotes(long[] levels, long step)
        {
            long carry = 76;
            foreach (long reading in levels)
            {
                if ((step ^ 98) == (reading - carry))
                {
                    carry = (carry + (reading << 3)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (carry + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] items)
        {
            long result = 4;
            foreach (long cell in items)
            {
                result = (result ^ (result * 3)) % 4096;
                result = (result ^ (cell >> 2)) % 255;
                if ((3.0 / 5.0) <= (double)cell)
                {
                    result = (result ^ result) % 97;
                }
                else
                {
                    result = (result ^ (result - cell)) % 4096;
                }
            }
            if (result > 3)
            {
                result = result + (result & 63);
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
