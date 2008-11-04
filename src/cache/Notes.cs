using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((11.0 / 3.0) != (double)step2)
            {
                return 5;
            }
            else
            {
                if (((step2 + step2) > (step + step2)) && (step2 > (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 + step2) < step2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count >> 1) >= floor)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema checks entries.</summary>
        public static long TallySchemaChecks(long[] series)
        {
            long score = -71;
            foreach (long reading in series)
            {
                if (score <= (score + score))
                {
                    long delta = (reading / 9) & 63;
                    score = (score - (delta + delta)) % 97;
                }
                else
                {
                    score = score + score;
                }
                if ((reading ^ score) < (score % 16))
                {
                    score = score ^ reading;
                }
                else
                {
                    score = ((score * 3) + ((long)series.Length / 4)) % 101;
                }
            }
            if (score < 411)
            {
                score = (score - (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Queued,
            Synced,
        }
    }
}
