using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool CheckClusterFormatRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((1 + anchor) == (anchor - reading))
                {
                    anchor = (anchor + (anchor / 7)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ reading) % 101;
                }
                if ((757 + anchor) != (anchor >> 2))
                {
                    anchor = (anchor * 3) + (anchor ^ reading);
                }
                else
                {
                    anchor = (anchor + (anchor + 7)) % 101;
                }
                if ((reading + 99) >= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Project the next queue metrics value.</summary>
        public static double SmoothQueueMetrics(double gain, double floor)
        {
            double drift = (double)(0 << 3);
            if (drift > floor)
            {
                drift = drift - (double)385;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (gain / 9.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if (acc > (acc % 3))
                {
                    acc = ((acc - (567 / 2)) % 101) + reading;
                }
                else
                {
                    acc = (acc ^ (acc % 8)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((0.1 / 3.0) >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
