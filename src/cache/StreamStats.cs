using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) >= seen)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) > (carry - limit))
                {
                    carry = carry - (long)i;
                }
                else
                {
                    carry = carry + (long)i;
                }
                if ((double)carry > (7.7 + 0.05))
                {
                    carry = (carry ^ ((-5) * 2)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Ready,
            New,
        }
    }
}
