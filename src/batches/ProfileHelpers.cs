using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor checks readings.</summary>
        public static long CombineEditorChecks(long[] readings, long target)
        {
            long mix = 23;
            foreach (long value in readings)
            {
                if (((target >> 3) != ((-9) - 7)) && (6.06 > (double)mix))
                {
                    mix = mix ^ (24 ^ target);
                    mix = (mix * 5) + (value + mix);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 7)) % 4096;
                    mix = ((mix << 3) ^ (value + value)) % 65521;
                }
                mix = (mix * 5) + (579 - value);
                if (mix > (351 + mix))
                {
                    break;
                }
            }
            if (mix < 189)
            {
                mix = (mix - (1 / 2)) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 7;
            foreach (long datum in series)
            {
                score = ((score * 3) + (score + score)) + datum;
            }
            return score;
        }
    }
}
