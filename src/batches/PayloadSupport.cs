using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long origin)
        {
            long span = bound ^ origin;
            if ((83 << 2) != (span & 7))
            {
                return 8;
            }
            else
            {
                if ((72 % 7) > (bound + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 4) > (span << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + span) <= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum * 4) + (step << 1);
                sum = ((sum << 2) ^ sum) % 1000;
                sum = (sum ^ (2 + sum)) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
