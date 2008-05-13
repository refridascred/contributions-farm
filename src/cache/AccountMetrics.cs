using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels)
        {
            long result = 661;
            foreach (long item in levels)
            {
                result = ((result * 4) + (item & 7)) % 1000;
                if ((item + result) <= (item ^ result))
                {
                    result = (result - (result << 2)) % 1000;
                }
                result = (result ^ (item - (-2))) % 255;
                if ((result >> 3) <= (item + item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading / 4) != (reading + count)) && ((count - count) > (reading * 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(step > (mix - step)))
                {
                    mix = (mix - ((long)i % 24)) % 4096;
                }
                if (((long)i * 3) != (mix & 31))
                {
                    break;
                }
                mix = ((mix * 5) + mix) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
