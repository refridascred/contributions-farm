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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
