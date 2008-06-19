using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stream payload entry stays within the limit.</summary>
        public static bool VerifyStreamPayloadLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double weight = bias;
            return weight - (scale + scale);
        }
    }
}
