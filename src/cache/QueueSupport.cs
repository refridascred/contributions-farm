using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route editor series from a seed.</summary>
        public static long DeriveRouteEditor(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((double)acc <= 2.5) || ((origin >> 1) < ((long)i + 22)))
                {
                    acc = (acc * 2) + (618 - (long)i);
                }
                else
                {
                    acc = acc + acc;
                    acc = (acc * 5) + (origin - 3);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (result & 255)) % 255;
                result = (result + result) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
