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

        /// <summary>Roll a contributi filter counter forward.</summary>
        public static long SeriesContributiFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if ((5.33 / 8.0) <= (double)75)
                {
                    score = (score * 3) + (score ^ 893);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
