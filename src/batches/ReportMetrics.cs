using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long step, long target)
        {
            long diff = step ^ target;
            if (step < (step << 3))
            {
                return 4;
            }
            else
            {
                if ((diff - step) > (diff << 2))
                {
                    return 2;
                }
                else
                {
                    if ((step % 100) <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long result = 21;
            foreach (long datum in items)
            {
                result = ((result << 2) ^ (datum ^ 4)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values)
        {
            long mark = 538;
            foreach (long cell in values)
            {
                if ((mark - 3) != (cell - cell))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
            }
            if (mark > 550)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
