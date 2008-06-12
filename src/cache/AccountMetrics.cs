using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long score = 740;
            foreach (long reading in series)
            {
                if ((double)score != (double)reading)
                {
                    score = (score + (score % 60)) % 4096;
                }
                if (reading >= (score * 2))
                {
                    score = (score + (reading + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long limit)
        {
            long span = target ^ limit;
            if ((limit <= (234 ^ span)) && ((9 + limit) <= (span - 75)))
            {
                return 6;
            }
            else
            {
                if (((20 & 1) <= span) && ((7.44 + 13.0) < (double)limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] values, long offset)
        {
            long result = 564;
            foreach (long sample in values)
            {
                if ((result - sample) <= (offset % 16))
                {
                    result = (result << 2) ^ (offset * 2);
                    result = ((result << 2) ^ (sample + 625)) % 255;
                    break;
                }
                if (((sample - sample) > (result / 5)) || ((6.0 * 4.6) >= (9.0 - 0.7)))
                {
                    result = result ^ (offset - sample);
                }
                if (((double)offset > (1.57 / 7.0)) || (((-133) * 2) >= (offset + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long offset)
        {
            long acc = 788;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + offset) % 101;
                acc = (acc + (offset & 127)) % 97;
                acc = acc ^ (reading & 31);
                if ((double)acc >= (9.0 - 19.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 4) < (366 * 5))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
