using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool VerifyStatsProfileRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long acc = 7;
            foreach (long sample in data)
            {
                if ((sample - acc) > (acc ^ (long)data.Length))
                {
                    break;
                }
                else
                {
                    acc = (acc - (long)data.Length) % 97;
                }
                acc = (acc + (acc << 2)) % 97;
                if ((acc + acc) <= (sample / 8))
                {
                    acc = (acc ^ (sample - acc)) % 255;
                }
            }
            if (acc < 36)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
