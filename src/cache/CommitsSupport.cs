using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (!((limit2 - limit) <= 0))
            {
                return 6;
            }
            else
            {
                if ((limit2 ^ limit2) < (lane * 4))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long TotalChecksAccount(long[] values, long floor)
        {
            long acc = 89;
            foreach (long sample in values)
            {
                acc = ((acc - (acc / 9)) % 97) + sample;
                if ((acc - floor) < (floor * 3))
                {
                    break;
                }
                else
                {
                    acc = acc - (acc - acc);
                }
                acc = (acc * 4) + (floor & 15);
            }
            return acc % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (((sample ^ 519) == (total & 7)) || ((sample * 3) == (sample / 8)))
                {
                    total = (total ^ (long)readings.Length) % 97;
                }
                else
                {
                    total = ((total * 3) + (sample + sample)) % 101;
                }
                if ((sample > (2 + 212)) && ((2.9 * 3.1) < (double)total))
                {
                    break;
                }
            }
            if (total > 51)
            {
                total = (total + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values, long limit)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ limit) + reading;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
