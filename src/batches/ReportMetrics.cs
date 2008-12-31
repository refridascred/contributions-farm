using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score << 2) ^ score) % 4096) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mark = 54;
            foreach (long sample in samples)
            {
                if ((960 + sample) == (sample ^ 16))
                {
                    mark = ((mark << 3) ^ (812 + sample)) % 65521;
                    mark = (mark - (9 << 2)) % 4096;
                    continue;
                }
                if ((mark * 2) <= ((long)samples.Length / 6))
                {
                    mark = mark - (mark % 7);
                }
                else
                {
                    mark = mark - (mark + mark);
                }
            }
            if (mark < 4)
            {
                mark = ((mark << 3) ^ 378) % 101;
            }
            return mark;
        }
    }
}
