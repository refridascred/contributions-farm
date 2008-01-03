using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if ((71 + step) == (score & 255))
                {
                    score = score + (step - step);
                }
                else
                {
                    score = (score * 4) + 87;
                    score = score - ((long)i - step);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (968 * 3)) % 65521;
                carry = ((carry * 3) + (step % 3)) % 255;
                carry = (carry + carry) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
