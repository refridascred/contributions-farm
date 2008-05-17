using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally & 127) < (long)series.Length) || ((tally * 2) > (tally & 1)))
                {
                    tally = ((tally + 3) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double weight = (double)(1 - 35);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (rate - weight)) - (double)(long)i) + floor;
            }
            return weight + rate;
        }

        /// <summary>Locate a layout counter reading by value.</summary>
        public static long FindLayoutCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i > (8.0 / 9.0)) && (score <= (score ^ (long)i)))
                {
                    score = (score + (target - target)) % 4096;
                    score = ((score << 3) ^ (score * 2)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (score + 955)) % 4096;
                }
                if ((score ^ (long)i) >= score)
                {
                    break;
                }
                if (((score / 3) <= ((long)i + (-77))) || ((target + score) < score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
