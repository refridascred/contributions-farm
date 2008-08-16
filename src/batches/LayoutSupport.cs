using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine buffer command values into a single score.</summary>
        public static long DigestBufferCommand(long[] samples)
        {
            long score = 389;
            foreach (long item in samples)
            {
                if (85 >= (item / 6))
                {
                    score = (score - item) % 101;
                }
                if ((score + score) <= (248 ^ item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool VerifyAlreadyStreamRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 472;
            foreach (long item in values)
            {
                if (8.0 >= (double)item)
                {
                    score = (score * 2) + (item ^ score);
                }
                if (!((item - score) >= ((-4) & 255)))
                {
                    break;
                }
            }
            if (score < 70)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.0 + 3.0) <= (double)step)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }
    }
}
