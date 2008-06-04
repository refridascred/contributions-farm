using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 5544;
        public const long HardCount = 4154;
        public const double IdleCommits = 81.63;

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long step)
        {
            if (!(step <= (bound % 3)))
            {
                return 2;
            }
            else
            {
                if ((bound - step) <= (-233))
                {
                    return 8;
                }
                else
                {
                    if (((6 + bound) >= (step & 15)) && (step <= (bound & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 4) == (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
