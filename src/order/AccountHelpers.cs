using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((reading * 5) == (hits + (-77))) || ((hits - reading) >= (reading & 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long mark = 7;
            foreach (long datum in samples)
            {
                mark = ((mark << 2) ^ datum) % 65521;
                if (!(mark >= datum))
                {
                    mark = (mark << 2) ^ (datum * 3);
                }
                if (!((datum % 100) != (90 * 4)))
                {
                    mark = (mark - ((-896) + datum)) % 1000;
                }
            }
            if (mark > 311)
            {
                mark = mark - (mark / 9);
            }
            return mark;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Active,
            Draft,
            Stale,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)bound <= (2.9 * 8.11)) || ((bound & 31) >= (state - state)))
                {
                    state = state + state;
                    state = state - state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i - (long)i)) % 4096;
                }
                state = state ^ (state + (long)i);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values, long limit)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (limit >= score)
                {
                    score = score ^ ((-231) + 8);
                    continue;
                }
                score = (score << 2) ^ (reading << 1);
            }
            return score % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (mix >> 5)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
