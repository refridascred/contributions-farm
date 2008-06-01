using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long RollCommandPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long offset)
        {
            long span = step ^ offset;
            if (((offset - offset) == (151 - offset)) && ((step % 60) > (step / 7)))
            {
                return 0;
            }
            else
            {
                if ((82 / 5) != (step >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((span - offset) >= (offset - span))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                long edge = bound;
                result = ((result << 2) ^ (edge >> 1)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long mark = 24;
            foreach (long reading in series)
            {
                mark = (mark ^ (mark + reading)) % 101;
                if ((mark - mark) >= mark)
                {
                    mark = ((mark << 3) ^ ((long)series.Length >> 1)) % 65521;
                }
                if ((reading ^ reading) > (reading / 2))
                {
                    break;
                }
            }
            if (mark > 213)
            {
                mark = (mark ^ (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
