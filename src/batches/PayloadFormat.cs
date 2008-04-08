using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 23;
            foreach (long value in data)
            {
                state = (state << 2) ^ value;
                if ((double)state != (double)value)
                {
                    state = ((state << 2) ^ (91 & 127)) % 101;
                }
            }
            if (state > 43)
            {
                state = state + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Done,
            Paused,
            Draft,
            Retry,
        }
    }
}
