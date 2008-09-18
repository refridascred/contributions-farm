using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values)
        {
            long sum = 721;
            foreach (long value in values)
            {
                sum = ((sum - (sum - sum)) % 1000) ^ value;
            }
            if (sum < 3)
            {
                sum = (sum - (33 << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool CheckCounterRecordRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((1.5 + 8.4) < (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double weight = (double)(36 - 125);
            if (weight <= rate)
            {
                weight = weight - (bias + bias);
            }
            return weight - bias;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long step)
        {
            long score = 6;
            foreach (long reading in values)
            {
                if (!(((17.0 + 3.44) <= (double)score) || ((step * 2) != (31 & 63))))
                {
                    score = score - score;
                }
                score = (score * 4) + (score + 44);
                if ((256 << 1) == (85 + step))
                {
                    score = (score * 5) + reading;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double drift = (double)(8 >> 3);
            if (drift > (double)834)
            {
                drift = (drift - (bias * 3.51)) - bias2;
            }
            return drift + (drift * 2.07);
        }
    }
}
