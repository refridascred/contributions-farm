using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long result = 290;
            foreach (long entry in levels)
            {
                result = (result * 3) + (entry - entry);
                result = ((result * 5) + 3) % 97;
            }
            if (result < 2)
            {
                result = (result * 3) + result;
            }
            return result % 97;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long lane = bound - target;
            if ((bound + lane) < (6 - 266))
            {
                return 1;
            }
            else
            {
                if (8 >= (lane % 8))
                {
                    return 3;
                }
                else
                {
                    if ((target & 15) >= (bound ^ lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up order route samples.</summary>
        public static long MatchOrderRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long TotalSchemaPayload(long[] values)
        {
            long score = 73;
            foreach (long sample in values)
            {
                if ((score ^ score) != (score & 255))
                {
                    score = score + (7 + sample);
                }
                if ((score + score) < (276 + 57))
                {
                    score = score - (sample + sample);
                    score = score ^ sample;
                }
                if ((16.0 * 6.03) >= (double)score)
                {
                    score = ((score << 2) ^ (score % 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen > (item - seen)) || ((double)164 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
