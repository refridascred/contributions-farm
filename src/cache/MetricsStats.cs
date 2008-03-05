using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item & 15) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 478;
            foreach (long sample in series)
            {
                if ((3.94 / 4.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc & 127)) + sample;
                }
            }
            if (acc < 495)
            {
                acc = (acc ^ (acc >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long offset, long step)
        {
            if ((step ^ 31) >= offset)
            {
                return 8;
            }
            else
            {
                if (((offset + offset) > (step + offset)) && ((offset * 2) <= (step - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((step - offset) < (offset + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data)
        {
            long score = -203;
            foreach (long cell in data)
            {
                if (score > (score - cell))
                {
                    score = ((score * 4) + (63 - score)) % 65521;
                }
                else
                {
                    score = (score + score) % 255;
                }
            }
            if (score > 137)
            {
                score = (score + (score / 6)) % 4096;
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > 9.1) || ((1.91 > (double)entry) || ((matches - matches) > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
