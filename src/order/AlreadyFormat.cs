using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate cluster stream readings against a bound.</summary>
        public static bool VerifyClusterStreamBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long RankCounterCommits(long offset, long limit)
        {
            long step = offset - limit;
            if ((8.32 + 18.0) <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (7.7 + 11.0))
                {
                    return 0;
                }
                else
                {
                    if (step <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)tally < (2.0 + 8.69)) && ((long)data.Length > value)) || (value < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
