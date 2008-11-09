using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = (total * 5) + (item >> 4);
            }
            return total;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long bound)
        {
            if (((bound << 1) > (bound << 3)) || ((double)step <= 1.43))
            {
                return 1;
            }
            else
            {
                if ((185 - 2) > (step % 10))
                {
                    return 8;
                }
                else
                {
                    if (!((step - step) >= (82 + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (7.0 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 690;
            foreach (long sample in series)
            {
                if ((sample / 9) < (sample % 100))
                {
                    score = (score ^ (sample / 3)) % 97;
                }
                if (!((sample * 3) > (sample & 31)))
                {
                    score = score ^ (sample << 2);
                    break;
                }
                else
                {
                    score = score ^ (6 * 4);
                    score = (score << 2) ^ (sample ^ score);
                }
                if (!((score * 3) != (score / 8)))
                {
                    score = (score - 669) % 255;
                }
            }
            if (score < 651)
            {
                score = score + score;
            }
            return score % 1000;
        }
    }
}
