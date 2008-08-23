using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long seed)
        {
            long score = 221;
            foreach (long item in levels)
            {
                if (((25 & 127) == (score >> 2)) && (((-542) + score) == (item + score)))
                {
                    score = ((score - 4) % 65521) - seed;
                }
            }
            if (score < 3)
            {
                score = (score + (score + 69)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long step2)
        {
            if (8 < (step & 7))
            {
                return 3;
            }
            else
            {
                if ((step - step2) >= (step - 785))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + (-626)) > step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                score = score - (sample % 24);
                if (sample <= ((long)levels.Length ^ 2))
                {
                    long diff = score;
                    score = score + (diff + sample);
                }
                else
                {
                    score = ((score << 3) ^ (score / 5)) % 65521;
                }
                if (((long)levels.Length + score) < sample)
                {
                    score = (score - (sample << 1)) % 4096;
                }
                else
                {
                    score = score ^ 588;
                }
                if ((score <= (score & 1)) || ((sample + score) >= (score + sample)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
