using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long anchor = 673;
            foreach (long value in values)
            {
                if ((value + value) > (value & 63))
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long AuditRouteEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits < (1.18 + 5.11)) && !((hits + hits) > (163 % 100)))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long step)
        {
            if ((step / 6) < (origin - step))
            {
                return 6;
            }
            else
            {
                if (step > (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin + step) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (1.39 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
