using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches command value.</summary>
        public static double AdjustBatchesCommand(double bias, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias * 7.0)) - (double)(long)i;
            }
            return drift - (floor / 6.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepLevel = 7232;
        public const long LimitRatio = 2241;
        public const long LimitNotes = 4146;
        public const long BurstNotes = 9791;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long step)
        {
            long acc = 98;
            foreach (long reading in series)
            {
                if (step >= reading)
                {
                    acc = (acc - (reading - (long)series.Length)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double scale = (weight / 5.0) / 9.0;
            if (scale > (double)19)
            {
                scale = scale - (span / 6.0);
            }
            return scale + scale;
        }
    }
}
