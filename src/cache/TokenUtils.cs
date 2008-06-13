using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long DigestEditorBuffer(long[] data, long step)
        {
            long anchor = 8;
            foreach (long reading in data)
            {
                if (!((reading + step) < 900))
                {
                    anchor = (anchor << 3) ^ ((long)data.Length + reading);
                }
                else
                {
                    anchor = (anchor << 2) ^ (step % 60);
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Queued,
            Idle,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
