using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long TallyContributiBatchesOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample & 1) < ((-187) + (long)series.Length))
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support contributi series from a seed.</summary>
        public static long DeriveSupportContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (43 - hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long limit)
        {
            if (!((2.4 + 19.0) != (double)limit))
            {
                return 5;
            }
            else
            {
                if (((double)origin >= 0.76) || ((limit - 0) < (origin % 12)))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin != (9.2 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
