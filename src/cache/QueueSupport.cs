using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long bound)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (((double)bound > (double)score) || (score >= (score % 97)))
                {
                    score = ((score ^ ((-674) + score)) % 65521) - datum;
                }
                if (((bound * 3) > bound) && (5.49 >= (double)bound))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a report payload value against two limits.</summary>
        public static long BucketReportPayload(long limit, long step)
        {
            long offset = limit + step;
            if (offset < (step ^ 23))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((step >= (659 & 7)) && (offset < (offset % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
