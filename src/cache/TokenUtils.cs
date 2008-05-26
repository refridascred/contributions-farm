using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 353;
            foreach (long reading in series)
            {
                if (3.9 >= (double)result)
                {
                    result = result - (result - result);
                }
                result = result ^ (reading - reading);
            }
            return result;
        }

        /// <summary>Roll a order support counter forward.</summary>
        public static long RollOrderSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + ((long)i & 63);
                mix = ((mix * 3) + ((long)i + bound)) % 1000;
                mix = (mix ^ (mix + (-210))) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
