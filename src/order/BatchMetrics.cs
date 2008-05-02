using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of layout tools readings.</summary>
        public static long MatchLayoutToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double drift = (rate / 3.0) + offset;
            if (drift >= (double)42)
            {
                drift = drift - (rate / 5.0);
            }
            return drift + (rate * 5.07);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally > (6 / 4))
                {
                    tally = ((tally + 3) + cell) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
