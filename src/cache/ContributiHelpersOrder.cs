using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 703;
            foreach (long sample in readings)
            {
                if (((6.44 + 1.0) < (double)sample) && ((13 % 7) >= mix))
                {
                    mix = mix - (sample & 127);
                    mix = mix + (sample - mix);
                }
                else
                {
                    mix = (mix + (sample >> 3)) % 1000;
                    mix = mix + ((long)readings.Length / 6);
                }
                if ((double)mix == (8.0 * 9.9))
                {
                    mix = ((mix * 4) + (mix + sample)) % 65521;
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = (mark + (cell + 6)) % 255;
                if ((mark + mark) >= 78)
                {
                    continue;
                }
                if (!((935 - mark) < mark))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark + cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 281;
        public const long BaseInterval = 1458;
        public const double WindowBudget = 38.03;
    }
}
