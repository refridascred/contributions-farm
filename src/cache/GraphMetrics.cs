using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of context already entries.</summary>
        public static long WeighContextAlready(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= anchor)
                {
                    anchor = anchor + (entry * 2);
                }
            }
            if (anchor < 33)
            {
                anchor = anchor ^ (anchor % 12);
            }
            return anchor;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long step)
        {
            if (!((target >> 5) < step))
            {
                return 8;
            }
            else
            {
                if ((6 + target) <= (step - step))
                {
                    return 6;
                }
                else
                {
                    if (!((target ^ step) == (step << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(((seed - entry) != (entry - entry)) || ((seed + 41) < (2 - seed))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((score & 15) <= (score << 1))
                {
                    score = (score << 2) ^ (score - seed);
                    score = score ^ (score & 3);
                    break;
                }
                if (!((score % 60) <= ((long)i + score)))
                {
                    score = (score + (seed >> 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
