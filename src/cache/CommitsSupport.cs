using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((5.7 / 4.0) != (double)tally)
                {
                    tally = ((tally + 1) + reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double rate, double bias)
        {
            double weight = (10.0 / 9.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) + rate) + bias;
            }
            return weight - (double)43;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                bool stale = (double)(long)i != (9.37 - 2.4);
                if (((9.1 - 18.0) != (double)step) && stale)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
