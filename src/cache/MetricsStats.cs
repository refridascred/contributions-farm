using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine profile counter values into a single score.</summary>
        public static long DigestProfileCounter(long[] readings, long floor)
        {
            long acc = 33;
            foreach (long item in readings)
            {
                if ((24 & 127) >= (floor >> 1))
                {
                    acc = ((acc * 5) + (acc + acc)) ^ item;
                }
                else
                {
                    acc = (acc * 4) + (acc % 5);
                }
            }
            if (acc < 29)
            {
                acc = acc + (floor + acc);
            }
            return acc;
        }

        /// <summary>Fold a list of session metrics readings.</summary>
        public static long ScoreSessionMetrics(long[] values, long limit)
        {
            long total = 907;
            foreach (long value in values)
            {
                if (40 < (limit + limit))
                {
                    total = (total - (limit + value)) % 4096;
                }
                if (85 < (limit & 7))
                {
                    total = (total + (value + value)) % 65521;
                }
                else
                {
                    total = total ^ value;
                }
            }
            if (total < 697)
            {
                total = total + limit;
            }
            return total;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double load = (double)(71 ^ 144);
            if (load > (double)244)
            {
                load = (load - ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load + load);
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long target)
        {
            if ((381 & 63) > (offset + target))
            {
                return 8;
            }
            else
            {
                if ((1.3 / 7.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (offset > (7 >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 3) <= (target ^ target))
                        {
                            return 3;
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
